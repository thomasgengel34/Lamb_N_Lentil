document.getElementById("submitButton").onclick = function () {
    document.getElementById("whereToWriteSearchingAlso").innerText = "....Searching.........";
    document.getElementById("whereToWriteSearchingAlso").style.color = "red";
    document.getElementById("No_results").textContent = " ";
    document.getElementById("searchTextLeastFiveCarb").innerText = " ";
}

document.getElementById("LFCsubmitButton").onclick = function () {
    document.getElementById("whereToWriteSearchingAlso").innerText = "....Searching.........";
    document.getElementById("whereToWriteSearchingAlso").style.color = "red";
    document.getElementById("No_results").textContent = " ";
    document.getElementById("searchText").innerText = " ";
} 