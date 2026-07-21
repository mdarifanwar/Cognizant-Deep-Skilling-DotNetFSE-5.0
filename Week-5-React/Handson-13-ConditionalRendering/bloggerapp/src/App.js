import React from "react";
import "./App.css";

import BookDetails from "./Components/BookDetails";
import BlogDetails from "./Components/BlogDetails";
import CourseDetails from "./Components/CourseDetails";

import {
  books,
  blogs,
  courses
} from "./Components/Data";

function App() {

  // Conditional Rendering using Element Variable
  let bookSection = <BookDetails books={books} />;

  // Conditional Rendering using Ternary Operator
  let blogSection =
    blogs.length > 0 ? (
      <BlogDetails blogs={blogs} />
    ) : (
      <h3>No Blogs Available</h3>
    );

  // Conditional Rendering using &&
  let courseSection =
    courses.length > 0 && (
      <CourseDetails courses={courses} />
    );

  return (
    <div className="container">

      <div className="column">
        {courseSection}
      </div>

      <div className="column">
        {bookSection}
      </div>

      <div className="column">
        {blogSection}
      </div>

    </div>
  );
}

export default App;