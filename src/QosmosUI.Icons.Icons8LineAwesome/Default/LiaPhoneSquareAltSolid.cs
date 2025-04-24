// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaPhoneSquareAltSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 5 5 L 5 27 L 27 27 L 27 5 L 5 5 z M 7 7 L 25 7 L 25 25 L 7 25 L 7 7 z M 20.126953 9 C 19.614953 9 19.134438 9.1985469 18.773438 9.5605469 L 17.623047 10.710938 C 16.900047 11.433938 16.900047 12.695922 17.623047 13.419922 L 19.330078 15.126953 C 18.803078 15.897953 18.197484 16.62125 17.521484 17.28125 L 17.269531 17.53125 C 16.615531 18.20125 15.893047 18.806031 15.123047 19.332031 L 13.416016 17.625 C 13.055016 17.263 12.5735 17.064453 12.0625 17.064453 C 11.5515 17.064453 11.070031 17.263 10.707031 17.625 L 9.5566406 18.777344 C 8.8126406 19.522344 8.8125938 20.736375 9.5585938 21.484375 L 10.511719 22.439453 C 11.039719 22.965453 11.802047 23.139578 12.498047 22.892578 L 12.628906 22.849609 C 13.131906 22.684609 14.310734 22.298109 16.177734 21.037109 C 17.085734 20.425109 17.935359 19.716453 18.693359 18.939453 L 18.927734 18.705078 C 19.711734 17.939078 20.419203 17.091594 21.033203 16.183594 C 22.294203 14.314594 22.679703 13.135812 22.845703 12.632812 L 22.888672 12.501953 C 22.961672 12.292953 22.998047 12.076281 22.998047 11.863281 C 22.998047 11.367281 22.802594 10.884625 22.433594 10.515625 L 21.480469 9.5605469 C 21.117469 9.1985469 20.637953 9 20.126953 9 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
