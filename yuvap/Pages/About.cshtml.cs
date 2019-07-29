using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace yuvap.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "अविवाहित युवक युवती परिचय सम्मेलन दौरान जो प्रत्याशी एक दूसरे को मिलना चाहते है उनको अपनी (preference) पसंद के प्रत्याशीयो का registration number introduction session के बाद इस website के फ़ॉर्म में अपने मोबाइल के ज़रिए डालना है। इसके लिए आपको login करने की ज़रूरत नहीं है। यह data admin के द्वारा process करके आपको ये जानकारी तुरंत website से आपके मोबाइल पर दी जायगी कि आपको कौन प्रत्याशी मिलना चाहता है।(ये जानकारी अन्यथा मिल नहीं सकती।) इसके बाद उन प्रत्याशीयो को मिलने के लिए आपके पास पूरा समय रहता है।      कृपया ध्यान दीजिए: एक बार entry submit कारनेके बाद आप ख़ुद इसमें सुधार नहीं कर सकते। कोईभी दिक़्क़त हो तो admin से बात करने पर समाधान निकल सकता है।";
        }
    }
}
