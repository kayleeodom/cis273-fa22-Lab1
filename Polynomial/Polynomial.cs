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
            // check for if the coefficient is equal to 0
            if (coeff == 0)
            {
                return;
            }
            var currentNode = terms.First;
            while( currentNode != null )
            {
                // check for matching power
                if( power == currentNode.Value.Power)
                {
                    currentNode.Value.Coefficient += coeff;
                    return;
                }

                // check for lesser power
                if ( power > currentNode.Value.Power)
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

		// TODO
        public override string ToString()
        {
            string result = "";
            if(NumberOfTerms == 0)
            {
                return "0";
            }

            foreach( var term in terms)
            {
                
				result += term.ToString();
                if (term != terms.Last.Value)
                {
                    result += "+";
                }
               
            }

            return result;
        }

		public static Polynomial Add(Polynomial p1, Polynomial p2)
		{
			Polynomial result = new Polynomial();

            // add all the terms from p1 to sum
            foreach( var term in p1.terms)
            {
                result.AddTerm(term.Coefficient, term.Power);
            }

            // add all the terms from p2 to sum
            foreach (var term in p2.terms)
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
            foreach (var term in p1.terms)
            {
                difference.AddTerm(term.Coefficient, term.Power);
            }
            // subtract all the terms from p2
            foreach (var term in p2.terms)
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
            foreach (var term in p.terms)
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
            while (p1 != null)
            {
                p2 = p2;
                while (p2 != null)
                {
                    
                }
            }
            return product;
        }


    }
}

