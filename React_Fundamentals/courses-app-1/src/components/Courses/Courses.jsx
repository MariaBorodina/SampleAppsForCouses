import List from '@mui/material/List';

const Courses = function(props) {

    return (
        <List>
            {props.children}
        </List>
    );
}


export default Courses;