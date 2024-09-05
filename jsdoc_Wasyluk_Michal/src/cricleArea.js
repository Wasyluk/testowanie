/**
 * @description divides 2 numbers
 * @throws {Error} If `radius' is lower or equal to 0
 * @param {number} radius radius of circle
 * @returns {number} area of circle with given radius
 * @example
 * let circleArea = calculateArea(5);
 * @author Michał Wasyluk 5D
 */
function calculateArea(radius) {
    if (radius > 0)
        return 3.14 * radius*radius
    else
        throw new Error("Radius is lower than zero")
}
