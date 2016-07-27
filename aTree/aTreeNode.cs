using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aTree
{
    class aTreeNode : TreeNode
    {
        private object _DetailObject;
        public object DetailObject {

            get {
                return _DetailObject;
            }
            set {
                _DetailObject = value;
            }
        }

        private aTreeControlledObjectCategory _ObjectCategory;
        public aTreeControlledObjectCategory ObjectCategory
        {

            get {
                return _ObjectCategory;
            }
            set {
                _ObjectCategory = value;
            }
        }




        //FullName
        //aTreeNodeInheritedType
        //ObjectInherit
        //ContainerInherit
        //ContainerOnly
        //NoPropagationInherit

        //
    }
}
