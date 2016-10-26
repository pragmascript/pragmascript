﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PragmaScript
{
    partial class Backend
    {

        public void TransformAST(AST.Root root)
        {
            transform(root);
        }

        void transform(AST.Root node)
        {
            foreach (var decl in node.declarations)
            {
                if (decl is AST.FunctionDefinition)
                {
                    transform(decl as AST.FunctionDefinition);
                }
            }
        }


        void transform(AST.FunctionDefinition node)
        {

        }


    }
}
