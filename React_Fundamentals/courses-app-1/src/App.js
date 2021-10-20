import './App.css';
import {ThemeProvider} from '@mui/material/styles';
//import Header from './components/Header/Header';
import Courses from './components/Courses/Courses';
import CourseCard from './components/CourseCard/CourseCard';
import theme from './theme';

function App() {


  return (
    <ThemeProvider theme={theme}>
    <div className="App">
      {/* <Header individuumName='Dave'>        
      </Header> */}

      <Courses>
        <CourseCard 
          title='Java' 
          authors='Dave Simmons' 
          duration='8 hours' 
          created='01.01.2011'
          description = 'gkjfcghll lg hlgjh fjg hlgj g!'
         />

        <CourseCard 
          title='ASP.NET' 
          authors='Some One' 
          duration='12 hours' 
          created='01.01.2012'
          description = 'gkjfljlHKKHK HOHK HKL cghll lg hlgjh fjg hlgj g!'
         />
      </Courses>
    </div>
    </ThemeProvider>
  );
}

export default App;
