using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWP_Assignment_music.Entity;

namespace UWP_Assignment_music.Service
{
    class GoogleDriveFileService : IFileService
    {
        public Task<MemberCredential> ReadMemberCredentialFromFile()
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveMemberCredentialToFile(MemberCredential memberCredential)
        {
            throw new NotImplementedException();
        }

        public void SignOutByDeleteToken()
        {
            throw new NotImplementedException();
        }
    }
}
