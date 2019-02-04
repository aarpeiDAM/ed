package com.example.ssuma;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.EditText;
import android.view.View;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    public void suma(View view){
        EditText editText = (EditText) findViewById(R.id.num1);
        int num1= Integer.parseInt(editText.getText().toString());
        editText = (EditText) findViewById(R.id.num2);
        int num2= Integer.parseInt(editText.getText().toString());
        int resultadoF=num1+num2;
        TextView textView =findViewById(R.id.resultado);
        textView.setText(Integer.toString(resultadoF));

    }
}
