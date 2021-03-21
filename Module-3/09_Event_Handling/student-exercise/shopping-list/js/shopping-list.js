let allItemsIncomplete = true;
const button = document.getElementById("toggleAll")
const pageTitle = 'My Shopping List';
const groceries = [
  { id: 1, name: 'Oatmeal', completed: false },
  { id: 2, name: 'Milk', completed: false },
  { id: 3, name: 'Banana', completed: false },
  { id: 4, name: 'Strawberries', completed: false },
  { id: 5, name: 'Lunch Meat', completed: false },
  { id: 6, name: 'Bread', completed: false },
  { id: 7, name: 'Grapes', completed: false },
  { id: 8, name: 'Steak', completed: false },
  { id: 9, name: 'Salad', completed: false },
  { id: 10, name: 'Tea', completed: false }
];

document.addEventListener("DOMContentLoaded", initializePage);

function initializePage() {
  setPageTitle();
  displayGroceries();

}

/**
 * This function will get a reference to the title and set its text to the value
 * of the pageTitle variable that was set above.
 */
function setPageTitle() {
  const title = document.getElementById('title');
  title.innerText = pageTitle;
}

/**
 * This function will loop over the array of groceries that was set above and add them to the DOM.
 */
function displayGroceries() {
  const ul = document.querySelector('ul');
  groceries.forEach((item) => {
    const li = document.createElement('li');
    li.innerText = item.name;
    const checkCircle = document.createElement('i');
    checkCircle.setAttribute('class', 'far fa-check-circle');
    li.addEventListener("click", (ev) => {
      if (!ev.target.classList.contains("completed")) {
        ev.target.querySelector("i").classList.add("completed");
        ev.target.classList.add("completed");
      }
    });

    checkCircle.addEventListener("click", (ev) => {
      if(!ev.target.classList.contains("completed")){
        li.classList.add("completed");
        ev.target.classList.add("completed");

      }});
    
    li.addEventListener('dblclick', (ev) =>{
      if(ev.target.classList.contains('completed')){
        checkCircle.classList.remove('completed');
        ev.target.classList.remove('completed');

      }
    });
    checkCircle.addEventListener('dblclick', () => {
      if(checkCircle.classList.contains('completed')){
        checkCircle.classList.remove('completed');
        li.classList.remove('completed');
      }
    })
    li.appendChild(checkCircle);
    ul.appendChild(li);
  });
}

// function allItemsIncomplete(){
//   let button = document.getElementById("toggleAll");
//   let itemsList = document.querySelector("ul");
//   if(!itemsList.classList.contains("completed")){
//     button.innerText("Mark All Complete");
//   }
// }



function markAllItems(){
  const checkCircle = document.querySelectorAll("i");
  const itemsList = document.querySelectorAll("li");
  if(allItemsIncomplete){
    button.innerText = "Mark All Incomplete";
    allItemsIncomplete = false;  
    itemsList.forEach( (item) => {
      item.classList.add("completed");
    });
    checkCircle.forEach( (circle) => {
      circle.classList.add("completed");
    });
  }else if(allItemsIncomplete === false){
    button.innerText = "Mark All Completed";
    allItemsIncomplete = true;  
    itemsList.forEach( (item) => {
      item.classList.remove("completed");
    });
    checkCircle.forEach( (circle) => {
      circle.classList.remove("completed");
    });
  }
}

button.addEventListener('click', markAllItems);

