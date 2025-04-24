// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaJoget : ComponentBase
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
		builder.AddAttribute(14, "d", "M 16 3 C 8.832 3 3 8.832 3 16 C 3 23.168 8.832 29 16 29 C 23.168 29 29 23.168 29 16 C 29 8.832 23.168 3 16 3 z M 16 5 C 22.065 5 27 9.935 27 16 C 27 16.402757 26.976005 16.79973 26.933594 17.191406 C 24.411573 17.18943 17.473247 17.233463 14.953125 17.167969 C 11.872125 17.098969 10.418938 16.012953 11.710938 14.501953 C 12.991937 12.978953 14.226031 12.228625 15.207031 11.640625 C 16.199031 11.063625 16.684141 9.8063906 13.869141 10.025391 C 8.3648999 10.399383 6.0625804 13.440264 5.0058594 15.867188 C 5.0780433 9.8637834 9.979814 5 16 5 z M 21.582031 12 C 20.589031 12 18.916609 13.419516 17.474609 14.353516 C 15.732609 15.495516 13.851562 16.095703 13.851562 16.095703 L 23.255859 16.003906 L 25.988281 14.664062 C 25.988281 14.664063 26.184734 14.133547 24.927734 13.810547 C 23.669734 13.475547 21.616797 14.469422 19.966797 15.357422 C 18.316797 16.234422 18.248047 15.806641 18.248047 15.806641 C 18.248047 15.806641 20.831203 13.869719 21.408203 13.511719 C 21.997203 13.154719 23.185203 12.738391 22.158203 12.150391 C 21.973203 12.046391 21.778031 12 21.582031 12 z M 26.091797 20.367188 C 24.398056 24.264986 20.513385 27 16 27 C 15.298844 27 14.614291 26.926814 13.949219 26.800781 C 13.565765 26.168524 13.195705 25.506682 13.037109 25.140625 C 12.703109 24.367625 11.468891 22.56675 14.837891 21.34375 C 17.532234 20.368736 23.588388 20.392244 26.091797 20.367188 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
