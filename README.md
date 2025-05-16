
To create record use 
-----------------------------------------------------
mutation { 
    addUser(user: {
      id : 3, name: "jessie", username: "jessie"
    }) 
    {
      id
    }
}