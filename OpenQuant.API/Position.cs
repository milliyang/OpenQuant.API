using SmartQuant.Instruments;
using System;
namespace OpenQuant.API
{
	public class Position
	{
		internal SmartQuant.Instruments.Position position;
		private TransactionList transactions;
		public Instrument Instrument
		{
			get
			{
				return OpenQuant.Instruments[this.position.Instrument.Symbol];
			}
		}
		public PositionSide Side
		{
			get
			{
				switch (this.position.Side)
				{
				case SmartQuant.Instruments.PositionSide.Long:
					return PositionSide.Long;
				case SmartQuant.Instruments.PositionSide.Short:
					return PositionSide.Short;
				default:
					throw new NotImplementedException("Unknown PositionSide : " + this.position.Side);
				}
			}
		}
		public double EntryPrice
		{
			get
			{
				return this.position.EntryPrice;
			}
		}
		public DateTime EntryDate
		{
			get
			{
				return this.position.EntryDate;
			}
		}
		public double EntryQty
		{
			get
			{
				return this.position.EntryQty;
			}
		}
		public double Amount
		{
			get
			{
				return this.position.Amount;
			}
		}
		public double Qty
		{
			get
			{
				return this.position.Qty;
			}
		}
		public double QtyBought
		{
			get
			{
				return this.position.QtyBought;
			}
		}
		public double QtySold
		{
			get
			{
				return this.position.QtySold;
			}
		}
		public double QtySoldShort
		{
			get
			{
				return this.position.QtySoldShort;
			}
		}
		public double Margin
		{
			get
			{
				return this.position.Margin;
			}
		}
		public double Debt
		{
			get
			{
				return this.position.Debt;
			}
		}
		public TransactionList Transactions
		{
			get
			{
				return this.transactions;
			}
		}
		internal Position(SmartQuant.Instruments.Position position)
		{
			this.position = position;
			this.transactions = new TransactionList(position.Transactions);
		}
		public double GetPrice()
		{
			return this.position.Price();
		}
		public double GetValue()
		{
			return this.position.GetValue();
		}
		public double GetMarginValue()
		{
			return this.position.GetMarginValue();
		}
		public double GetDebtValue()
		{
			return this.position.GetDebtValue();
		}
		public double GetLeverage()
		{
			return this.position.GetLeverage();
		}
		public double GetCashFlow()
		{
			return this.position.GetCashFlow();
		}
		public double GetNetCashFlow()
		{
			return this.position.GetNetCashFlow();
		}
		public double GetPnL()
		{
			return this.position.GetPnL();
		}
		public double GetNetPnL()
		{
			return this.position.GetNetPnL();
		}
		public double GetPnLPercent()
		{
			return this.position.GetPnLPercent();
		}
		public double GetNetPnLPercent()
		{
			return this.position.GetNetPnLPercent();
		}
		public double GetUnrealizedPnL()
		{
			return this.position.GetUnrealizedPnL();
		}
		public TimeSpan GetDuration()
		{
			return this.position.GetDuration();
		}
	}
}
