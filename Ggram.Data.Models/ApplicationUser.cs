using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ggram.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            Posts = new HashSet<Post>();
            Friends = new List<UserFriend>();
            FriendsTo = new List<UserFriend>();
            FriendRequestsSent = new List<FriendRequest>();
;       }
        //1.1 First Name
        public string FirstName { get; set; }

        //1.2 Last Name
        public string LastName { get; set; }

        public HashSet<Post> Posts { get; set; }


        [InverseProperty(nameof(UserFriend.User))]
        public List<UserFriend> Friends { get; set; }

        [InverseProperty(nameof(UserFriend.Friend))]
        public List<UserFriend> FriendsTo { get; set; }

        [InverseProperty(nameof(FriendRequest.Sender))]
        public List<FriendRequest> FriendRequestsSent { get; set; }
    }
}
