/**
 * @description divides 2 numbers
 * @throws {Error} if age is lower or equal to zero
 * @param {number} age age of person
 * @returns {boolean} whether a person of given age is an adult
 * @example
 * let isAdult = isAdult(19);
 * @author Michał Wasyluk 5D
 */
function isAdult(age) {
    if (age > 0)
        return age >= 18;
    else
        throw new Error("Age lower or equal to zero")

}
