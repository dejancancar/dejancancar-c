// add pageTitle
const pageTitle = 'My Shopping List';

// add groceries
let groceries = ["Pizza", "Bread", "Sprite", "Hot Dogs", "Cheese", "Lucky Charms", "Wine", "Eggs", "Lettuce", "Cookies"]

/**
 * This function will get a reference to the title and set its text to the value
 * of the pageTitle variable that was set above.
 */
function setPageTitle() {
  let titleElement = document.getElementById('title');
  titleElement.innerText = pageTitle;
}

/**
 * This function will loop over the array of groceries that was set above and add them to the DOM.
 */
function displayGroceries() {
  groceries.forEach((item) => {
    let itemList = document.createElement('li');
    itemList.innerText = item;

    let list = document.getElementById('groceries');
    list.insertAdjacentElement('beforeEnd',itemList);
  });
}

/**
 * This function will be called when the button is clicked. You will need to get a reference
 * to every list item and add the class completed to each one
 */
function markCompleted() {
  let listItems = document.querySelectorAll('li');
  listItems.forEach( (item) => {
    item.classList.add('completed');
  });
}

setPageTitle();

displayGroceries();

// Don't worry too much about what is going on here, we will cover this when we discuss events.
document.addEventListener('DOMContentLoaded', () => {
  // When the DOM Content has loaded attach a click listener to the button
  const button = document.querySelector('.btn');
  button.addEventListener('click', markCompleted);
});
