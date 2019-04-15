package sample;

import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.fxml.FXML;
import javafx.scene.control.Label;
import javafx.scene.control.TableView;
import javafx.event.ActionEvent;

public class Controller {
    @FXML private TableView<Persona> tableInVbox;
    @FXML private Label label1;
    @FXML ObservableList<Persona> personas= FXCollections.observableArrayList(
            new Persona("Luis","665 687 879" ),
            new Persona("Sergio","687 676 786" ),
            new Persona("Ismail","687 665 879" )
    );

    public void initialize(){
        System.out.println("Hola");
        tableInVbox.setItems(personas);
        label1.setText(Integer.toString(tableInVbox.getItems().size()));
    }
    @FXML private void captureOnClick(ActionEvent actionEvent){

        personas.add(new Persona("Boton","665 687 879" ));
    }

    public static class Persona{

        private String nombre, telefono;

        public Persona(String nombre, String telefono) {
            this.nombre = nombre;
            this.telefono = telefono;
        }

        public String getNombre() {
            return nombre;
        }

        public void setNombre(String nombre) {
            this.nombre = nombre;
        }

        public String getTelefono() {
            return telefono;
        }

        public void setTelefono(String telefono) {
            this.telefono = telefono;
        }
    }
}
