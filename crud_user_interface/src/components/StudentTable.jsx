import React from "react";
import AddStudentForm from "./AddStudentForm";

const getGenderLabel = (gender) => {
  switch (gender) {
    case 0:
      return "Male";
    case 1:
      return "Female";
    case 2:
      return "NonBinary";
    case 3:
      return "Other";
    default:
      return "Unknown";
  }
};

const StudentTable = ({ students, onEdit, onDelete }) => {
  // Check if students is not an array, and if so, initialize it as an empty array
  if (!Array.isArray(students)) {
    students = [];
  }

  console.log("Students in StudentTable:", students); // Log students in StudentTable component

  return (
    <div>
      <AddStudentForm />
      <table className="table table-striped">
        <thead>
          <tr>
            <th>Student Name</th>
            <th>Department</th>
            <th>Gender</th>
            <th>Date of Birth</th>
            <th>Age</th>
            <th>Is Graduated</th>
            <th>Action</th>
          </tr>
        </thead>
        <tbody>
          {students.map((student, index) => (
            <tr key={index}>
              <td>{`${student.firstName} ${""} ${student.lastName}`}</td>
              {/* <td>{student.lastName}</td> */}
              <td>{student.department}</td>
              <td>{getGenderLabel(student.gender)}</td>{" "}
              {/* Render gender label */}
              <td>{student.dateOfBirth}</td>
              <td>{student.age}</td>
              <td>{student.isGraduated ? "Yes" : "No"}</td>
              <td>
                <button
                  className="btn btn-primary mr-2"
                  onClick={() => onEdit(index)}
                >
                  Edit
                </button>
                <button
                  className="btn btn-danger"
                  onClick={() => onDelete(index)}
                >
                  Delete
                </button>
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
};

export default StudentTable;
