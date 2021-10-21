import List from '@mui/material/List';
import CourseCard from '../CourseCard/CourseCard';

const Courses = function(props) {

    return (
        <List>
            {props.items.map(course => 
                <CourseCard item={course}></CourseCard>)}
        </List>
    );
}


export default Courses;