// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaStripeS : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 32 32";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M 16.515625 4 C 10.735625 4 7 7.1135938 7 11.933594 C 7 16.706594 11.288953 18.129313 14.126953 19.070312 C 15.402953 19.493313 16.989 20.018109 17 20.537109 C 16.992 20.938109 16.042562 21 15.476562 21 C 13.590563 21 10.698359 20.220516 8.4433594 19.103516 L 7 18.388672 L 7 26.185547 L 7.6113281 26.441406 C 9.9583281 27.427406 12.707297 27.995 15.154297 28 C 21.319297 28 25 25.158391 25 20.400391 C 25 15.208391 20.591781 13.797281 17.675781 12.863281 C 16.609781 12.521281 15 12.005219 15 11.574219 C 15 11.345219 15.000469 11 16.230469 11 C 18.079469 11 20.652281 11.765375 22.488281 12.859375 L 24 13.761719 L 24 5.546875 L 23.363281 5.2988281 C 21.207281 4.4608281 18.776625 4 16.515625 4 z M 16.515625 6 C 18.314625 6 20.237 6.3276875 22 6.9296875 L 22 10.361328 C 20.114 9.5223281 17.953469 9 16.230469 9 C 13.315469 9 13 10.800219 13 11.574219 C 13 13.465219 14.975406 14.098578 17.066406 14.767578 C 20.541406 15.880578 23 16.934391 23 20.400391 C 23 25.453391 17.51325 26 15.15625 26 C 13.17525 25.996 10.967 25.576797 9 24.841797 L 9 21.537109 C 10.993 22.334109 13.465563 23 15.476562 23 C 18.530563 23 18.997 21.465969 19 20.542969 L 19 20.537109 L 19 20.53125 C 18.992 18.57525 16.934859 17.893875 14.755859 17.171875 C 11.385859 16.053875 9 15.024594 9 11.933594 C 9 8.2725937 11.879625 6 16.515625 6 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
