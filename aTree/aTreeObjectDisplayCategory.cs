using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aTree
{
   public enum aTreeObjectDisplayCategory
    {
        Folder=0,
        FolderError=1,
        File=2,
        FileError=3,
        User=4,
        UserError=5,
        Group=6,
        GroupError=7,
        SecurityIdentifier=8,
        SecurityIdentifierError=9,
        InheritedUser=10,
        InheritedUserError=11,
        InheritedGroup=12,
        InheritedGroupError=13,
        InheritedSecurityIdentifier=14,
        InheritedSecurityIdentifierError=15,
        Reparse=16
    }
}
