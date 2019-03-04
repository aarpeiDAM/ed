package com.example.apares;

import android.os.Handler;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

import java.util.ArrayList;
import java.util.List;
import java.util.Random;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {
    public String palabraClave="";
    public List<String> listaPalabras= new ArrayList<String>();
    public List<Button> listaBotonesVacios= new ArrayList<Button>();
    public List<Button> listaBotonesRellenos= new ArrayList<Button>();
    public List<String> listaBotonesRellenos2= new ArrayList<String>();
    public TextView textView;
    public TextView textView2;
    public int actualScore=0;
    public int botonC=0;
    public int indexTarget=0;
    Handler handler = new Handler();
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        textView = findViewById(R.id.respuesta);
        textView2 = findViewById(R.id.score);
        ponerPalabrasEnBotones();
        textView2.setText("Score: "+Integer.toString(actualScore));

    }
    public int establecerRandom(int valor){
        Random rand = new Random();
        int random = rand.nextInt(valor);
        return random;
    }
    public void ponerPalabrasEnBotones(){
        listaPalabras.add("Leche");
        listaPalabras.add("Vaca");
        listaPalabras.add("Huevos");
        listaPalabras.add("Cerdos");
        listaPalabras.add("Pollos");
        listaPalabras.add("Conejos");
        listaPalabras.add("Cabras");
        listaPalabras.add("Ovejas");
        listaPalabras.add("Lana");
        listaPalabras.add("Cuero");
        listaPalabras.add("Trigo");
        listaPalabras.add("Zanahorias");
        for (int i = 1; i < 13; i++) {
            int id = getResources().getIdentifier("button"+i, "id", getPackageName());
            Button btn = findViewById(id);
            listaBotonesVacios.add(btn);
        }
        int random=establecerRandom(listaPalabras.size());
        palabraClave=listaPalabras.get(random);
        textView.setText(palabraClave);
        listaPalabras.remove(random);
        random=establecerRandom(listaBotonesVacios.size());
        listaBotonesVacios.get(random).setText(palabraClave);
        listaBotonesRellenos.add(listaBotonesVacios.get(random));
        botonC=listaBotonesRellenos.get(0).getId();
        listaBotonesVacios.remove(random);
        for (int i = 0; i < 11; i++) {
            random=establecerRandom(listaPalabras.size());
            String palabraAPoner=listaPalabras.get(random);
            listaPalabras.remove(random);
            random=establecerRandom(listaBotonesVacios.size());
            listaBotonesVacios.get(random).setText(palabraAPoner);
            listaBotonesRellenos.add(listaBotonesVacios.get(random));
            listaBotonesVacios.remove(random);
        }
        for(int i = 0; i<listaBotonesRellenos.size();i++){
            listaBotonesRellenos2.add(listaBotonesRellenos.get(i).getText().toString());
        }
        handler.postDelayed(new Runnable() {
            @Override
            public void run() {
                for (int i = 0; i < 12; i++) {
                    listaBotonesRellenos.get(i).setText("");

                }
            }
        }, 5000);

    }
    public void comprobar(View view){
        Button b = (Button)view;
        int buttonPos = b.getId();
        if(buttonPos==botonC){
            textView.setText("Correcto");
            actualScore+=1;
            if(actualScore!=12){
            Handler handler = new Handler();
            handler.postDelayed(new Runnable() {
                @Override
                public void run() {
                    actualizarScore();
                }
            }, 2000);}
            else{
                textView2.setText("Score: "+Integer.toString(actualScore));
                textView.setText("Has ganado");
            }
        }
    }
    public void actualizarScore(){
        textView2.setText("Score: "+Integer.toString(actualScore));
        cambiarTarget();
        textView.setText(listaBotonesRellenos2.get(indexTarget));

    }
    public void cambiarTarget(){
        listaBotonesRellenos2.remove(indexTarget);
        listaBotonesRellenos.remove(indexTarget);
        indexTarget=establecerRandom(listaBotonesRellenos2.size());
        botonC=listaBotonesRellenos.get(indexTarget).getId();

    }
}
/*Hay que hacer que en comprobar no guarde el texto vacio*/
