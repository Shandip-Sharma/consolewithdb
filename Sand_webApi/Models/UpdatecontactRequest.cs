﻿namespace Sand_webApi.Models
{
    public class UpdatecontactRequest
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public long PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
