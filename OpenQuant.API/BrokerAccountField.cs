using SmartQuant.Providers;
using System;
namespace OpenQuant.API
{
	public class BrokerAccountField
	{
		private SmartQuant.Providers.BrokerAccountField field;
		public string Name
		{
			get
			{
				return this.field.Name;
			}
		}
		public string Currency
		{
			get
			{
				return this.field.Currency;
			}
		}
		public string Value
		{
			get
			{
				return this.field.Value;
			}
		}
		internal BrokerAccountField(SmartQuant.Providers.BrokerAccountField field)
		{
			this.field = field;
		}
		public override string ToString()
		{
			return string.Format("Name={0} Currency={1} Value={2}", this.Name, this.Currency, this.Value);
		}
	}
}
