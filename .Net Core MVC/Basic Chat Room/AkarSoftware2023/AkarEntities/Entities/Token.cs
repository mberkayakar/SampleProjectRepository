using AkarEntities.Abstract;
using System;

namespace AkarEntities.Entities
{
    public class Token : BaseEntity
    {
        public Token()
        {
            OneTimeUsableToken = Guid.NewGuid().ToString();
        }
        public string OneTimeUsableToken { get; } 
        public User Person{ get; set; } 
        public Group Gruoup { get; set; }
        public bool IsUsed { get; set; } = false;


    }
}
