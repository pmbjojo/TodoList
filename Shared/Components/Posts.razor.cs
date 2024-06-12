using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Shared.Domains;

namespace TodoList.Shared.Components
{
    public partial class Posts
    {
        public List<Post> posts { get; set; }
        public Posts()
        {
            posts = new List<Post> { new Post() };
        }
    }
}
