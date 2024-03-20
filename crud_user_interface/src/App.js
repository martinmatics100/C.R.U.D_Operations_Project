import React, { useEffect, useState } from "react";
import logo from "./logo.svg";
import "./App.css";
import "bootstrap/dist/css/bootstrap.min.css";

import StudentTable from "./components/StudentTable";

function App() {
  const [students, setStudents] = useState([]);

  useEffect(() => {
    const fetchData = async () => {
      try {
        const response = await fetch(
          "https://localhost:7265/api/Student/get-all-students"
        );
        if (!response.ok) {
          throw new Error("Failed to fetch data");
        }
        const data = await response.json();
        console.log("Response data:", data); // Log the response data
        setStudents(data.data);
      } catch (error) {
        console.error("Error fetching data:", error);
      }
    };

    fetchData();
  }, []);

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
      <h1>Hello WOrld</h1>
      <p>C Sharp</p>
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
