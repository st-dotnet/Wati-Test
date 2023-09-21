using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Wati_Test_Integer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AddController : ControllerBase
    {
        private readonly IIntegerContext _context;
        public AddController(IIntegerContext context)
        {
            _context = context;
        }

        public int Post(IntegerModel model)
        {
            if(string.IsNullOrEmpty(model.Integer1.ToString()) || string.IsNullOrEmpty(model.integer2.ToString()))
                throw new ArgumentNullException(nameof(model));
            var sum= model.Integer1+ model.integer2;
            var entity = new IntegerSumEntity
            {
                Id=1,
                IntegerSum = sum
            };
            _context.IntegerSumEntity.Add(entity);
            _context.SaveChanges();
            return sum;
        }
    }
}
