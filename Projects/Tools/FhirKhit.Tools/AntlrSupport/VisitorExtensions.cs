using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FhirKhit.Tools.AntlrSupport
{
    /// <summary>
    /// Extension methods for visitor classes.
    /// </summary>
    public static class VisitorExtensions
    {
        /// <summary>
        /// Call visit if tree non null, otherwise return null.
        /// </summary>
        /// <param name="visitor">Visitor derived class</param>
        /// <param name="tree">parse tree (may be null)</param>
        /// <returns>null or value of Visit method</returns>
        public static Result VisitOrDefault<Result>(this AbstractParseTreeVisitor<Object> visitor,
          IParseTree tree)
        {
            if (tree == null)
                return default(Result);
            return (Result)visitor.Visit(tree);
        }

        /// <summary>
        /// Call visit if tree non null, otherwise return null.
        /// </summary>
        /// <param name="visitor">Visitor derived class</param>
        /// <param name="tree">parse tree (may be null)</param>
        /// <returns>null or value of Visit method</returns>
        public static Result VisitSingleOrDefault<Result>(this AbstractParseTreeVisitor<Object> visitor,
          IEnumerable<IParseTree> tree)
        {
            if (tree == null)
                return default(Result);
            switch (tree.Count())
            {
                case 0: return default(Result);
                case 1: return (Result)visitor.Visit(tree.First());
                default: throw new Exception("Expected single parse tree block");
            }
        }

        /// <summary>
        /// Call visit if tree non null, otherwise return null.
        /// </summary>
        /// <param name="visitor">Visitor derived class</param>
        /// <param name="tree">parse tree (may be null)</param>
        /// <returns>null or value of Visit method</returns>
        public static Result[] VisitMultiple<Result>(this AbstractParseTreeVisitor<Object> visitor,
          IEnumerable<IParseTree> tree)
        {
            if (tree == null)
                return new Result[0];
            Int32 count = tree.Count();
            Result[] retVal = new Result[count];
            Int32 index = 0;
            foreach (IParseTree treeItem in tree)
                retVal[index++] = (Result)visitor.Visit(treeItem);
            return retVal;
        }
    }
}
