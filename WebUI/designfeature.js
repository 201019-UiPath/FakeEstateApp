function GetAllFeatures()
{
    fetch('https://localhost:44341/Feature/GetAllFeatures') //fetch JSON list of houses
    .then(response => response.json())
    .then(result => {
        document.querySelectorAll('#features tbody tr').forEach(element => element.remove()); //clear table
        let table = document.querySelector('#features tbody'); //gets table element
        for (let i=0; i<result.length; i++) 
        {
            let row = table.insertRow(table.rows.length); //adds new row at the end
            let cell0 = row.insertCell(0);
            cell0.innerHTML = result[i].featureId;

            let cell1 = row.insertCell(1);
            cell1.innerHTML = result[i].description;

            let cell2 = row.insertCell(2);
            cell2.innerHTML = result[i].fee;
        }
    });
}