using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sand_webApi.Models;

namespace Sand_webApi.Controllers
{
    [ApiController]
    [Route("api/Contacts")]
    public class ContactsController : Controller
    {
        private readonly ContactContext dbContext;

        public ContactsController(ContactContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public ContactContext DbContext { get; }

        [HttpGet]
        public async Task<IActionResult> GetContacts()
        {
            return Ok( await dbContext.contacts.ToListAsync());

        }
        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetContact([FromRoute] Guid id)
        {
            var contact = await dbContext.contacts.FindAsync(id);
            if(contact==null)
            {
                return NotFound();
            }
            return Ok(contact);
        }
        [HttpPost]
      public async Task<IActionResult> AddContact(AddContactRequest addContactRequest)
        {
            var contact = new Contact()
            {
                Id = Guid.NewGuid(),
                FullName = addContactRequest.FullName,
                Address = addContactRequest.Address,
                Email = addContactRequest.Email,
                PhoneNumber = addContactRequest.PhoneNumber,
            };
          await  dbContext.contacts.AddAsync(contact);
            await dbContext.SaveChangesAsync();
            return Ok(contact);
        }
        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> updateContact([FromRoute] Guid id,UpdatecontactRequest updatecontactRequest)
        {
         var contact=await dbContext.contacts.FindAsync(id);
            if(contact!=null)
            {
                contact.FullName = updatecontactRequest.FullName;
                contact.Address = updatecontactRequest.Address;
                contact.Email = updatecontactRequest.Email;
                contact.PhoneNumber = updatecontactRequest.PhoneNumber;
                await dbContext.SaveChangesAsync();
                return Ok(contact);
            }
            return NotFound(id);
        }
        [HttpDelete]
        [Route("{id:guid}")]
        public  async Task<IActionResult> DeleteContact([FromRoute] Guid id)
        {
            var contact = await dbContext.contacts.FindAsync(id);
            if(contact!=null)
            {
                dbContext.Remove(contact);
              await  dbContext.SaveChangesAsync();
                return Ok(contact);
            }
            return NotFound();
        }
              

    }
}

      
    

        
      
    
 
    

