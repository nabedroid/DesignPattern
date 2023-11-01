using System;
using System.Collections.Generic;

namespace Composite {

  internal abstract class Component {

    public virtual void Add(Component component) { throw new NotImplementedException(); }
    public virtual string GetName() { throw new NotImplementedException(); }
    public virtual string GetDescription() { throw new NotImplementedException(); }
    public virtual string GetExtension() { throw new NotImplementedException(); }
    public virtual int GetSize() { throw new NotImplementedException(); }
    public virtual void Print() { throw new NotImplementedException(); }

  }

  internal class Folder : Component {

    private string _name;
    private string _description;
    private List<Component> _childs = new List<Component>();

    public Folder(string name, string description) {
      _name = name;
      _description = description;
    }

    public override void Add(Component component) {
      _childs.Add(component);
    }

    public override string GetName() { return _name; }
    public override string GetDescription() { return _description; }

    public override int GetSize() {
      int size = 0;
      foreach (Component child in _childs) {
        size += child.GetSize();
      }
      return size;
    }

    public override void Print() {
      Console.WriteLine($"[フォルダ] {_name} -- {_description}");
      foreach (Component child in _childs) {
        child.Print();
      }
    }
  }

  internal class File : Component {

    private string _name;
    private string _extension;
    private string _description;
    private int _size;

    public File(string name, string extension, string description, int size) {
      this._name = name;
      this._extension = extension;
      this._description = description;
      this._size = size;
    }

    public override string GetName() { return _name; }
    public override string GetExtension() { return _extension; }
    public override string GetDescription() { return _extension; }
    public override int GetSize() { return _size; }

    public override void Print() { Console.WriteLine($"[{_extension}] {_name} -- {_description} -- {_size}"); }
  }

  internal class MyTest {
    public static void main(string[] args) {
      /**
       * - root
       *   - folder 1
       *     - folder 1 1
       *       - folder 1 1 1
       *         * file
       *         * file
       *     - folder 1 2
       *       * file
       *   - folder 2
       *   * file
       *   * file
       */
      Component root = new Folder("root", "全ての起源");
      Component folder1 = new Folder("folder1", "フォルダその１");
      Component folder2 = new Folder("folder2", "フォルダその２");
      Component folder1_1 = new Folder("folder1-1", "フォルダその３");
      Component folder1_2 = new Folder("folder1-2", "フォルダその４");
      Component folder1_1_1 = new Folder("folder1-1-1", "フォルダその５");

      root.Add(new File("file1(root)", "ファイル", "ファイルその１", 1));
      root.Add(new File("file2(root)", "テキスト", "ファイルその２", 10));
      root.Add(folder1);
      root.Add(folder2);

      folder1.Add(folder1_1);
      folder1.Add(folder1_2);
      folder1_1.Add(folder1_1_1);
      folder1_1_1.Add(new File("file1(1-1-1)", "イメージ", "ファイルその３", 100));
      folder1_1_1.Add(new File("file2(1-1-1)", "ムービー", "ファイルその４", 1000));

      folder1_2.Add(new File("file1(1-2)", "シャープ", "ファイルその５", 10000));

      root.Print();
      Console.WriteLine($"合計サイズ: {root.GetSize()}");
    }
  }
}
