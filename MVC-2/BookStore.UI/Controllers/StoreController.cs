using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.UI.Controllers
{
    public class StoreController
    {
        private readonly IBookService _bookService;
        private readonly IMapper _mapper;
        
        public StoreController(IBookService bookService, IMapper mapper)
        {
            _bookService = bookService;
            _mapper = mapper;
        }
    }
}