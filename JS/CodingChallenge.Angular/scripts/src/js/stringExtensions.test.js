'use strict';

describe("Unit tests for string extensions ", function () {

    it("should return truthy when input is 'hang' passed to startsWith extension", function () {
        expect("hang the dj".startsWith("hang")).toBeTruthy();
    });

    it("should return falsy when input is 'Hang' passed to startsWith extension", function () {
        expect("hang the dj".startsWith("Hang")).toBeFalsy();
    });

    it("should return falsy when input is 'I've got a room for rent' passed to startsWith extension' ", function () {
        expect("hang the dj".startsWith("I've got a room for rent")).toBeFalsy();
    });

    it("should return truthy when input is '' passed to startsWith extension", function () {
        expect("hang the dj".startsWith("")).toBeTruthy();
    });

    it("should return truthy when input is 'hang the' passed to startsWith extension", function () {
        expect("hang the dj".startsWith("")).toBeTruthy();
    });

    it("should return falsy when input is 42 passed to startsWith extension", function () {
        expect("hang the dj".startsWith(42)).toBeFalsy();
    });

    it("should return falsy when input is 'Johnny' passed to startsWith extension", function () {
        expect("hang the dj".startsWith({ first: "Johnny" })).toBeFalsy();
    });
   

    it("should return truthy when input is 'dj' passed to endsWith extension", function () {
        expect("hang the dj".endsWith("dj")).toBeTruthy();
    });

    it("should return truthy when input is 'panic on the streets' passed to endsWith extension", function () {
        expect("hang the dj".endsWith("panic on the streets")).toBeFalsy();
    });

    it("should return falsy when input is '' passed to endsWith extension", function () {
        expect("hang the dj".endsWith("")).toBeTruthy();
    });

    it("should return falsy when input is 'the dj' passed to endsWith extension", function () {
        expect("hang the dj".endsWith("the dj")).toBeTruthy();
    });

    it("should return strip html tags from the input1", function () {
        expect("<p>Shoplifters of the World <em>Unite</em>!</p>".stripHtml()).toBe("Shoplifters of the World Unite!");
    });

    it("should return strip html tags from the input2", function () {
        expect("1 &lt; 2".stripHtml()).toBe("1 &lt; 2");
    });

});