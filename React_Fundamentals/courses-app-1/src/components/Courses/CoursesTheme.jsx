import { createTheme } from '@mui/system';
import theme from '../../theme';

const theme1 = createTheme(theme, {

    components: {
        // Name of the component
        MuiList: {
          styleOverrides: {
            // Name of the slot
            root: {
              // Some CSS
              fontSize: '1rem',
              borderColor: 'lightblue',
            
            },
          },
        },
      },


});


export default theme1;