using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter {

  public interface IPlus {
    int Plus(int x, int y);
  }

  public class CalcPlus : IPlus {
    public int Plus(int x, int y) {
      return x + y;
    }
  }

  public interface IMultiple {
    int Multiple(int x, int y);
  }

  public class CalcMultiple : IMultiple {
    public int Multiple(int x, int y) {
      return x * y;
    }
  }

  public class CalcPlusAdapter : IMultiple {
    private CalcPlus _plus;

    public CalcPlusAdapter(CalcPlus plus) {
      this._plus = plus;
    }

    public int Multiple(int x, int y) {
      int sum = 0;
      for (int i = 0; i < y; i++) {
        sum = this._plus.Plus(sum, x);
      }
      return sum;
    }
  }
}
