using System;
using System.Collections.Generic;
using System.Text;

namespace Framework2DGameMandatory
{
    public class WeaponDefence
    {
		private int _plainBlock;
		private int _percentageBlock;

        public WeaponDefence(int plainBlock, int percentageBlock)
        {
            _plainBlock = plainBlock;
            _percentageBlock = percentageBlock;
        }

		public int PercentageBlock
		{
			get { return _percentageBlock; }
			set { _percentageBlock = value; }
		}


		public int PlainBlock
		{
			get { return _plainBlock; }
			set { _plainBlock = value; }
		}

	}
}
