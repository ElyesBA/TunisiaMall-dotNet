using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunisiaMall.Domain.Entities;
using TunisiaMall.Service.Pattern;

namespace TunisiaMall.Service.Services
{
    public interface IGuestBookService: IService<guestbookentry>
    {
        IEnumerable<guestbookentry> GetGuestBookOrderByDate();
        IEnumerable<guestbookentry> GetGuestBookEntryByKeyword(string keyword);
        IEnumerable<guestbookentry> GetGuestBookEntryByDate(DateTime date);

        IEnumerable<guestbookentry> FindGuestBookEntry(DateTime date, string keyword);
    }
}
