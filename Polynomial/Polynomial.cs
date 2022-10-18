using System;
using System.Security.Cryptography.X509Certificates;

namespace Polynomial
{
	public class Polynomial
	{

		private LinkedList<Term> terms;

		public int NumberOfTerms => terms.Count;

		public int Degree => NumberOfTerms == 0 ? 0: terms.First.Value.Power;

		public Polynomial()
		{

			terms = new LinkedList<Term>();

		}

		public void AddTerm()
		{
			throw new NotImplementedException();
		}

		public override string ToString()
		{
			return base.ToString();
		}

		public static void Main()
		{
			Polynomial polynomial = new Polynomial();
		}
	}
}

