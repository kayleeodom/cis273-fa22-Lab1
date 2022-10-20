using System;
using System.Diagnostics.CodeAnalysis;
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

		// TODO
		public void AddTerm(double coeff, int power)
		{
			var currentNode = terms.First;
			while(currentNode != null)
			{
				// check for matching power
				if (power == currentNode.Value.Power)
				{
					// just found a matching power
					currentNode.Value.Coefficient += coeff;
					// if we do this that means we are done with this terma and should return 
					return;
				}
				// check for lesser power
				if(power > currentNode.Value.Power)
				{
					var newTerm = new Term(power, coeff);
					terms.AddBefore(currentNode, newTerm);
					return;
				}

				currentNode = currentNode.Next;
			}

			// Add new term to end of list
			terms.AddLast(new Term(power, coeff));
		}

		// TODO (ugly needs to be fixed)
		public override string ToString()
		{
			//return NumberOfTerms.ToString();
			string result = "";

			// don't need node information just the data
			foreach(var term in terms)
			{
				if(terms.Equals(0))
				{
					result = term.ToString();
				}
				else
				{
					result += term.ToString();
				}
               
			}
			// term is equal to last then don't add the + 

			return result;
		}

		// Static means they are properties of the class not an instance
		public static Polynomial Add(Polynomial p1, Polynomial p2)
		{
			Polynomial result = new Polynomial();
			// Add all the terms from p1 to sum
			foreach(var term in p1.terms)
			{
				result.AddTerm(term.Coefficient, term.Power);
			}

			// add all the terms from p2 to sum
			foreach(var term in p2.terms)
			{
				result.AddTerm(term.Coefficient, term.Power);
			}

			return result;
		}

		// this is the addition of negative (use negative and addition)
		public static Polynomial Subtract(Polynomial p1, Polynomial p2)
		{
			Polynomial difference = new Polynomial();
			// subtract all the terms from p1
			foreach(var term in p1.terms)
			{
				difference.AddTerm(term.Coefficient, term.Power);
			}
			// subtract all the terms from p2
			foreach(var term in p2.terms)
			{
				difference.AddTerm(term.Coefficient, term.Power);
			}

			return difference;
		}

		// Make it negative (change the sign of every term)
		// multiply each term by negative 1 
		// not changing the intial polynomial making a copy that is changed
		public static Polynomial Negate(Polynomial p)
		{
			Polynomial inverse = new Polynomial();
			foreach(var term in p.terms)
			{
				inverse.AddTerm(term.Coefficient * -1, term.Power);
				return inverse;

			}

			return inverse;
		}

		// addition and multiplication
		// nested for loop
        public static Polynomial Multiply(Polynomial p1, Polynomial p2)
		{
			Polynomial product = new Polynomial();
			//for
			return product;
		}


    }
}

