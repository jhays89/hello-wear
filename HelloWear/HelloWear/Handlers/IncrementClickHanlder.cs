using HelloWear.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWear.Handlers
{
    public class IncrementClickHanlder : Activity, IIncrementClickHanlder
    {
        private Activity _activity;

        public IncrementClickHanlder(Activity activity)
        {
            _activity = activity;
        }

        public void Initialize()
        {
            var count = 1;

            Button button = _activity.FindViewById<Button>(Resource.Id.click_button);
            TextView text = _activity.FindViewById<TextView>(Resource.Id.result);

            button.Click += delegate
            {
                text.Text = string.Format("{0} clicks!", count++);
            };
        }
    }
}
