using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class LineDTO
    {
        public int codeLine;
        public int lineNumber;
        public int codeArea;
        public double price;
        public int companyCode;

        public static LineDTO ToLineDTO(Line l)
        {
            LineDTO ll = new LineDTO();
            ll.codeLine = l.codeLine;
            ll.lineNumber = (int)l.lineNumber;
            ll.codeArea = (int)l.codeArea;
            ll.price = (double)l.price;
            ll.companyCode = (int)l.companyCode;

            return ll;
        }
        public static Line ToLine(LineDTO l)
        {
            Line ll = new Line();
            ll.codeLine = l.codeLine;
            ll.lineNumber = l.lineNumber;
            ll.codeArea = l.codeArea;
            ll.companyCode = l.companyCode;
            ll.price = l.price;
            return ll;
        }
        public static List<LineDTO> ToListLineDTO(List<Line> l)
        {
            List<LineDTO> ll = new List<LineDTO>();
            foreach (var item in l)
            {
                ll.Add(ToLineDTO(item));
            }
            return ll;
        }
        public static List<Line> ToListLine(List<LineDTO> l)
        {
            List<Line> ll = new List<Line>();
            foreach (var item in l)
            {
                ll.Add(ToLine(item));
            }
            return ll;
        }


    }
}
