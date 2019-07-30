                   //global var
                   //var strOptList = document.getElementById("selectTopRow").innerHTML;                        
                   //var numAttrib = 1;
                   function addRow(in_tbl_name){
                  
                        var tbody = document.getElementById(in_tbl_name).getElementsByTagName("TBODY")[0];
                        // create row
                        var row = document.createElement("TR");
                        // create table cell                
                        var td1 =  document.createElement("TD");
                        // td1.setAttribute(id,strAttrib);
                         
                       // var strOptList = document.getElementById("selectTopRow").innerHTML; //it is now global ?
                        var strHtml1 = "<select  value=\"\" name=\"PreferredGirls\"  style=\"width: 90px;\" >" +  strOptList  + "</select>" 
                        // onblur="myFunction()"  = Focuslost
                            
                        td1.innerHTML = strHtml1;

                        var td2 = document.createElement("TD")
                        //var strHtml2 = "<img src=\"~/Images/del-x.png\" onclick=\"delRow()\" style=\"width: 22px; cursor:pointer;\" />";
                          var strHtml2 = "<img src=\"/Images/del-x.png\" onclick=\"delRow()\" style=\"width: 22px; cursor: pointer;\" />";                                                    
                    
                        //td2.innerHTML = strHtml2.replace(/!count!/g, count); src="~/Images/del-x.png" 
                        td2.innerHTML = strHtml2;
                      
                        // append data to row
                        row.appendChild(td1);
                        row.appendChild(td2);
                        
                        // append rows to table
                        tbody.appendChild(row);     
                        
                    
                      // strAttrib = strAttrib + 1;                                                      
                    }

                    function delRow(){
                      var current = window.event.srcElement;                      
                       // del line 
                      var trtmp = current.parentElement.parentElement ;
                     // alert('This raw will be deleted!');
                      trtmp.parentElement.removeChild(trtmp);                
                    }

 
                    

/*
Help
(5) Ornamentation:
 - Flash file embeded: <object width="400" height="400" data="helloworld.swf"></object>
 - Show user the data selected before save.
 JavaScript. (a)Array.join() Method. Introduction: The array.join() method is an inbuilt function in JavaScript which is used to join the elements 
 of an array into a string.The elements of the string will be separated by a specified separator and its default value is comma(, ).
 (b) https://www.w3schools.com/jsref/jsref_tostring_array.asp
  var fruits = ["Banana", "Orange", "Apple", "Mango"];  fruits.toString();

(4) Data validation:
 - <option value="audi" selected>Audi</option>, try value=  ?No . try (i) value= ? not supported for 'select' .  (ii) name="", supported in 'select' 
 - onlostfocus event of td1 
 - before submit event to find duplicate in array of name-> property. 
 - Find duplicate : https://stackoverflow.com/questions/840781/get-all-non-unique-values-i-e-duplicate-more-than-one-occurrence-in-an-array
  (a) Find duplicate values in an array
This should be one of the shortest ways to actually find duplicate values in an array. As specifically asked for by the OP, this does not remove duplicates but finds them.

var input = [1, 2, 3, 1, 3, 1];

var duplicates = input.reduce(function(acc, el, i, arr) {
  if (arr.indexOf(el) !== i && acc.indexOf(el) < 0) acc.push(el); return acc;
}, []);

document.write(duplicates); // = 1,3 (actual array == [1, 3])
- * * * ---
(b) function find_duplicates(arr) {
  var len=arr.length,
      out=[],
      counts={};

  for (var i=0;i<len;i++) {
    var item = arr[i];
    counts[item] = counts[item] >= 1 ? counts[item] + 1 : 1;
    if (counts[item] === 2) {
      out.push(item);
    }
  }

  return out;
}

find_duplicates(['one',2,3,4,4,4,5,6,7,7,7,'pig','one']); // -> ['one',4,7] in no particular order.


(3) //Useful for password
Only 4 digit pin
Country code: <input type="text" name="country_code" pattern="[A-Za-z]{3}" title="Three letter country code"> //Useful for password
(2)
<div id="div" style="color:red;font-size:120%">Hello</div>

(1)Dt 7-2-19 https://javascript.info/dom-attributes-and-properties
Sure. All attributes are accessible by using the following methods:
elem.hasAttribute(name) – checks for existence.
elem.getAttribute(name) – gets the value.
elem.setAttribute(name, value) – sets the value.
elem.removeAttribute(name) – removes the attribute.

Example:
<div id="div" style="color:red;font-size:120%">Hello</div>
<script>
  // string
  alert(div.getAttribute('style')); // color:red;font-size:120%
  // object
  alert(div.style); // [object CSSStyleDeclaration]
  alert(div.style.color); // red
</script>

for (let attr of elem.attributes) { // (4) list all
      alert( `${attr.name} = ${attr.value}` );
    }

Non-standard attributes, dataset
 styles rely on the custom attribute "order-state" 
<style>  
  .order[order-state="new"] {
    color: green;
  }

  .order[order-state="pending"] {
    color: blue;
  }

  .order[order-state="canceled"] {
    color: red;
  }
</style>

<div class="order" order-state="new">
  A new order.
</div>

<div class="order" order-state="pending">
  A pending order.
</div>

<div class="order" order-state="canceled">
  A canceled order.
</div>

*/
 