import './App.css';
import {ThemeProvider} from '@mui/material/styles';
import Header from './components/Header/Header';
import Courses from './components/Courses/Courses';
import theme from './theme';
import {mockedCoursesList, mockedAuthorsList} from './mockData/data';

function mapCourseToAuthors (course) {
  course.authorList = course.authors.map(authorId => mockedAuthorsList.find(author => author.id === authorId)?.name).join(", ");
  return course;
}


function App() {


  const courses = mockedCoursesList.map(mapCourseToAuthors);

  return (
    <ThemeProvider theme={theme}>
    <div className="App">
      <Header individuumName='Dave'>        
      </Header>

      <Courses items={courses}></Courses>
    </div>
    </ThemeProvider>
  );
}

export default App;
