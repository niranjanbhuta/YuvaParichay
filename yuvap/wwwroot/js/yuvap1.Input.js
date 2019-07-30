                    function addRow(in_tbl_name){
                       // alert('hello in ver-1 ');
                        var tbody = document.getElementById(in_tbl_name).getElementsByTagName("TBODY")[0];
                        // create row
                        var row = document.createElement("TR");
                        // create table cell                
                        var td1 =  document.createElement("TD");
                        var strHtml1 = " <input type=\"text\" name=\"PreferredGirls\" value=\"\" />  ";  
                            
                        /*      <select asp-for="BoyLikes.BoyPrefers" class ="form-control" asp-items="ViewBag.BoyPrefers"></select>
                        As seen in 'Inspect Element' of Chrome Browser, It Renders To:->
                        <select class="form-control valid" data-val="true" data-val-required="The BoyPrefers field is required." id="BoyLikes_BoyPrefers" 
                        name="BoyLikes.BoyPrefers" aria-describedby="BoyLikes_BoyPrefers-error" aria-invalid="false"><option value="1">1</option>
<option value="2">2</option>
<option selected="selected" value="3">3</option>
<option value="4">4</option>
<option value="5">5</option>
</select>
                        */    
                        td1.innerHTML = strHtml1;

                        var td2 = document.createElement("TD")
                        var strHtml2 = "<img src=\"Images/del-x.png\" onclick=\"delRow()\" style=\"width: 22px; cursor:pointer;\" />";
                        //td2.innerHTML = strHtml2.replace(/!count!/g, count);
                        td2.innerHTML = strHtml2;
                      
                        // append data to row
                        row.appendChild(td1);
                        row.appendChild(td2);
                        // append rows to table
                        tbody.appendChild(row);      
                                       
                    }
                    function delRow(){
                        var current = window.event.srcElement;
                       // del line 
                      var trtmp = current.parentElement.parentElement ;
                     // alert('This raw will be deleted!')
                      trtmp.parentElement.removeChild(trtmp);
                    }
 