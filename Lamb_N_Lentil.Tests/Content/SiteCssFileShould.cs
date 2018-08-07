﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lamb_N_Lentil.Tests.Views;

namespace Lamb_N_Lentil.Tests.Content
{
    [TestClass]
    public class SiteCssFileShould : BaseViewTests
    { 
        static string testFileContents = @"html {
    width: 100%;
    margin-left: 0;
}

body {
    width: 100%;
    margin-left: 0;
    font-family: 'Lucida Handwriting';
    color: green;
    background: linear-gradient(90deg,rgba(250,207,78,0) 12%, transparent 0, transparent 99%, #dca 0);
}

#HomeAbout, #IngredientsIndex, .IngredientsDetails {
    padding-top: 50px;
    padding-bottom: 20px;
    background-size: 100px 100px;
    margin: 0;
    border-width: 0;
    margin-bottom: 0;
    min-height: 80vh;
    width: 90%;
    padding-left:5%;
}

#HomeIndex {
    background-color: lightgoldenrodyellow;
    width: 100%;
    height: 100%;
    margin: 0;
    padding: 0;
    background-image: none;
}

    #HomeIndex h1 {
        padding-top: 250px;
        background-color: lightgoldenrodyellow;
        margin-left: 0;
        font-size: 1200%;
        padding-bottom: 25%;
        margin-left: -9%;
        padding-left: 10%;
    }

    #HomeAbout li{
        font-size:125%;
    }

#IngredientsIndex {
    min-height: inherit; 
}

    #IngredientsIndex h1, #IngredientsDetails h1 {
        padding-top: -10%;
    }

    p{
        font-size:125%;
    }

 p a{
        color:blue;
        font-weight:500;
       text-decoration:underline;
    }

footer {
    border: inset green 5px;
    background-color: white;
    margin-left: -25%;
    margin-right: -25%;
    padding: 1%;
    text-align: center;
}


/* Set padding to keep content from hitting the edges */
.body-content {
    padding-left: 15px;
    padding-right: 15px;
}

/* Override the default bootstrap behavior where horizontal description lists 
   will truncate terms that are too long to fit in the left column 
*/
.dl-horizontal dt {
    white-space: normal;
}

/* Set width on the form input elements since they're 100% wide by default */
input,
select,
textarea {
    max-width: 280px;
}


.nav, .menu, .navbar-header, .navbar-collapse, .collapse, .navbar, .navbar-inverse, .navbar-fixed-top, .li {
    background-color: green;
    color: white;
}

#navA a, #navB a, #navC a {
    color: white;
}

    #navA a:hover, #navB a:hover, #navC a:hover, .col-md-4 {
        background-color: white;
        color: green;
    }

.navbar {
    margin-left: 0;
}


h1, h2, h3, h4, h5, h6, table, a {
    font-family: 'Lucida Handwriting';
    background: #ffd800;
    background-color: rgba(250,207,78,0);
    color: green;
}

h1 {
    margin-top: 0px;
}

a {
    text-decoration: underline;
}

.alert-container {
    position: fixed;
    left: 0;
    right: 0;
    padding-left: 3em;
    padding-right: 3em;
}

.container.body-content {
    padding-left: 6%;
    background-color: lightgoldenrodyellow;
    background-image: linear-gradient(90deg, transparent 79px, pink 79px, pink 80px, transparent 81px), linear-gradient(#eee .1em, transparent .4em);
    background-size: 100% 2.4em;
    min-height: 90vh;
    margin-left: 10%;
    margin-right: 5%;
}

h1 {
    padding-top: 19px;
}

h2 {
    padding-top: 20px;
}

p {
    line-height: 2.4em;
    margin-top: -10px;
}

#IngredientsIndexTable {
    background-color: white;
}

tr td:first-of-type {
    width: 40%;
    padding-left: 2%;
    background-color: white;
}

tr td:last-of-type {
    padding-right: 2%;
    background-color: white;
}

tr .leftpadding10 {
    padding-left: 10%;
}

.ingredientTextBox {
    padding: 1px;
    padding-left: 5px;
    width: 450px;
    max-width: 450px;
}

h2.no_results {
    color: red;
}

#IngredientsIndexTable tr th:last-child, #IngredientsIndexTable tr td:last-child {
    width: 5%;
    background-color: white;
}

/* Nutrition Label - begin*/
.NutritionLabel {
    border: solid black 1px;
    background: white;
    padding: 1%;
    font-family: Arial;
    color: black;
    width: 48%;
    /*border: 0;*/
    margin: 0 5px 0 5px;
}

    .NutritionLabel h1 {
        font-size: 25px;
        font-weight: 800;
        padding-bottom: 0;
        margin-bottom: 0;
        border-bottom: 0;
    }

    .NutritionLabel p:first-of-type {
        padding-top: 0;
        margin-top: 0;
        border-top: 0;
    }


    .NutritionLabel .thickHR {
        height: 25px;
        width: 100%;
        background-color: black;
        margin-top: -20px;
        padding-top: 0;
    }

    .NutritionLabel .mediumHR {
        height: 10px;
        width: 100%;
        background-color: black;
        margin-top: 0px;
        padding-top: 0;
    }


    .NutritionLabel .thinHR {
        height: 2px;
        width: 100%;
        background-color: black;
        padding: 0;
        margin: 0;
        clear: both;
    }


    .NutritionLabel > div {
        width: 100%;
    }

    .NutritionLabel h1, .NutritionLabel h2, .NutritionLabel p {
        background: white;
        padding: 1%;
        font-family: Arial;
        color: black;
    }

    .NutritionLabel .bold {
        font-weight: 800;
    }

    .NutritionLabel .indented {
        padding-left: 5%;
    }


    .NutritionLabel .right {
        display: block;
        float: right;
    }
/* Nutrition Label - end*/
";


private static string filePath = @"C:\Dev\TGE\Lamb_N_Lentil\Lamb_N_Lentil\Content\Site.css";
                                           

        public SiteCssFileShould() => ObtainFileAsString(filePath); 

        [TestMethod]
        public void LookLikeThis() =>  Assert.AreEqual(testFileContents,fileContents);  
    }
} 
