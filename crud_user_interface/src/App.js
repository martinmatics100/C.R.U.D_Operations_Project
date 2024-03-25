import React from "react";
import "./App.css";
import "bootstrap/dist/css/bootstrap.min.css";

import StudentTable from "./components/StudentTable";
import useFetchStudents from "./FetchApiEndpoints/useFetchStudents";

function App() {
  const { students } = useFetchStudents();

  const handleEdit = (index) => {
    // Implement edit logic
    console.log("Edit student at index:", index);
  };

  const handleDelete = (index) => {
    // Implement delete logic
    console.log("Delete student at index:", index);
  };

  console.log("Students in App:", students); // Log students in App component

  return (
    <div className="App">
      <h1>Student Details</h1>
      <StudentTable
        students={students}
        onEdit={handleEdit}
        onDelete={handleDelete}
      />
    </div>
  );
}

export default App;
