
function GetHouse()
{

}

function GetAllHouses()
{
    fetch('') //fetch JSON list of houses
    .then(response => response.json())
    .then(result => {
        document.querySelectorAll('#houses tbody tr').forEach(element => element.remove()); //clear table
        let table = document.querySelector('#houses tbody'); //gets table element
        for (let i=0; i<result.length; i++) 
        {
            let row = table.insertRow(table.rows.length); //adds new row at the end
            let cell0 = row.insertCell(0);
            //cell0.innerHTML = result[i].realName;

            let cell1 = row.insertCell(1);
            //cell1.innerHTML = result[i].alias;

            let cell2 = row.insertCell(2);
            //cell2.innerHTML = result[i].hideOut;

            //create button to access features
            let featCell = row.insertCell(6);
            let featButton = document.createElement("button");
            featButton.innerHTML = "View Features";
            featButton.setAttribute("class", "btn btn-info");
            featCell.innerHTML = featButton;
        }
    });
}