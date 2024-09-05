/**
 * @description divides 2 numbers
 * @throws {Error} If `b` is equal to `0`
 * @param {number} a divident
 * @param {number} b factor
 * @returns {number} result of dividing `a` by `b`
 * @example
 * let divisionResult = divide(10,2);
 * @author Michał Wasyluk 5D
 */
function divide(a,b) {
    if (b === 0)
        throw new Error("Divide by zero");
    else
        return a/b;
}

