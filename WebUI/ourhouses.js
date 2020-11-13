function GetAllHouses()
{
    fetch('https://localhost:44341/House/GetAllHouses') //fetch JSON list of houses
    .then(response => response.json())
    .then(result => {
        document.querySelectorAll('#houses tbody tr').forEach(element => element.remove()); //clear table
        let table = document.querySelector('#houses tbody'); //gets table element
        for (let i=0; i<result.length; i++) 
        {
            let row = table.insertRow(table.rows.length); //adds new row at the end
            let cell0 = row.insertCell(0);
            cell0.innerHTML = result[i].houseId;

            let cell1 = row.insertCell(1);
            cell1.innerHTML = result[i].location;

            let cell2 = row.insertCell(2);
            cell2.innerHTML = result[i].bedrooms;

            let cell3 = row.insertCell(3);
            cell3.innerHTML = result[i].bathrooms;

            let cell4 = row.insertCell(4);
            cell4.innerHTML = result[i].floors;

            let cell5 = row.insertCell(5);
            if (result[i].ac)
            {cell5.innerHTML = 'Yes';}
            else {cell5.innerHTML = 'No';}

            let cell6 = row.insertCell(6);
            if (result[i].heating)
            {cell6.innerHTML = 'Yes';}
            else {cell6.innerHTML = 'No';}

            let cell7 = row.insertCell(7);
            cell7.innerHTML = '$'+result[i].price.toLocaleString();

            //create button to access features
            let featCell = row.insertCell(8);
            featCell.innerHTML = '<input type="button" value="View Features" class="btn btn-info" id="feat'+i+'">';
            document.getElementById('feat'+i).onclick = () => window.location.href = "viewhouse.html?"+result[i].houseId;

            let deleteCell = row.insertCell(9);
            deleteCell.innerHTML = '<input type="button" value="X" class="btn btn-danger" id="del'+i+'">';
            document.getElementById('del'+i).onclick = () => DeleteHouse(result[i].houseId);
        }
    });
}

function DeleteHouse(houseId)
{
    if(confirm('Are you sure you want to delete house with ID='+houseId+'?'))
    {
        fetch('https://localhost:44341/House/DeleteHouse?id='+houseId, {method: 'DELETE'})
        .then(response =>
        {
            alert('Deleted house with ID='+houseId+'.');
            GetAllHouses();
        });
    }
}