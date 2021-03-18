/**
 * Write a function called isAdmitted. It will check entrance
 * scores and return true if the student is admitted and
 * false if rejected. It takes three parameters:
 *
 *     * gpa
 *     * satScore (optional)
 *     * recommendation (optional)
 *
 * Admit them--return true--if:
 * gpa is above 4.0 OR
 * SAT score is above 1300 OR
 * gpa is above 3.0 and they have a recommendation OR
 * SAT score is above 1200 and they have a recommendation
 * OTHERWISE reject it
 *
 * @param {number} gpa the GPA of the student, between 4.2 and 1.0
 * @param {number} [satScore=0] the student's SAT score
 * @param {boolean} [recommendation=false] does the student have a recommendation
 * @returns {boolean} true if they are admitted
 */
function isAdmitted(gpa, satScore = 0, recommendation = false) {
    if (gpa > 4.0 || satScore > 1300 || gpa > 3.0 && recommendation === true || satScore > 1200 && recommendation === true) {
        return true;
    }
    else {
        return false;
    }

}

/**
 * Write a function called useParameterToFilterArray that takes an anonymous
 * function and uses that in the `unfilteredArray` filter function. Return the result.
 *
 * @param {function} filterFunction the function to filter with
 * @returns {number[]} the filtered array
 */
let unfilteredArray = [1, 2, 3, 4, 5, 6];

function useParameterToFilterArray(filterFunction){
    return unfilteredArray.filter(filterFunction);
}

/**
 * Write a function called makeNumber that takes two strings
 * of digits, concatenates them together, and returns
 * the value as a number.
 *
 * So if two strings are passed in "42293" and "443", then this function
 * returns the number 42293443.
 *
 * @param {string} first the first string of digits to concatenate
 * @param {string} [second=''] the second string of digits to concatenate
 * @returns {number} the resultant number
 */
function makeNumber(str1, str2=""){ 
    let numberString =str1.concat(str2);
    return Number.parseInt(numberString);
}


/**
 * Write a function called addAll that takes an unknown number of parameters
 * and adds all of them together. Return the sum.
 *
 * @param {...number} num a series of numbers to add together
 * @returns {number} the sum of all the parameters (or arguments)
 */
function addAll(){
    let sum = 0;
    for (arg of arguments){
      if(typeof(arg) === "number"){
          sum += arg;  
      }
  
    }
    return sum;
}

/*
 * Write and document a function called makeHappy that takes
 * an array and prepends 'Happy ' to the beginning of all the
 * words and returns them as a new array. Use the `map` function.
 */
/**
 * 
 * @param {string} arr the array being passed in
 * @returns {array} an array wih "Happy " added to the begining of each index
 */
function makeHappy(arr){
    let str = 'Happy '
    return arr.map( (index) => {
        return str + index;
    });
}

/*
 * Write and document a function called getFullAddressesOfProperties
 * that takes an array of JavaScript objects containing the
 * following keys:
 *     * streetNumber
 *     * streetName
 *     * streetType
 *     * city
 *     * state
 *     * zip
 *
 * and returns an array of strings that turns the JavaScript objects
 * into a mailing address in the form of:
 *     streetNumber streetName streetType city state zip
 *
 * Use `map` and an anonymous function.
 */
function getFullAddressesOfProperties(arrOfObjects){
    let arrayOfStrings = arrOfObjects.map( (o) => {
        return `${o.streetNumber} ${o.streetName} ${o.streetType} ${o.city} ${o.state} ${o.zip}`;
    });
    return arrayOfStrings;
}

/*
 * Write and document a function called findLargest.
 *
 * Using `forEach`, find the largest element in an array.
 * It must work for strings and numbers.
 */
/**
 * 
 * @param {strings or numbers} array array to check for biggest number or a string number
 * @returns {number} returns the largest number in the array
 */
function findLargest(array){
    let biggest = array[0];
    array.forEach( (n) => {
        if(n > biggest){
            biggest = n;
        }
    } )
    return biggest;
}
/*
 * CHALLENGE
 * Write and document a function called getSumOfSubArrayValues.
 *
 * Take an array of arrays, adds up all sub values, and returns
 * the sum. For example, if you got this array as a parameter:
 * [
 *   [1, 2, 3],
 *   [2, 4, 6],
 *   [5, 10, 15]
 * ];
 *
 * The function returns 48. To do this, you will use two nested `reduce`
 * calls with two anonymous functions.
 *
 * Read the tests to verify you have the correct behavior.
 */
    function getSumOfSubArrayValues(array) {

        let result = array.reduce( (a, b) => {
          return a.concat(b);
        }).reduce( (a, b) => {
          return a + b;
        });
        return result;
      }

