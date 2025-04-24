// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaHryvniaSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 14.210938 5 C 13.220937 5 12.2625 5.2908438 11.4375 5.8398438 L 9.4453125 7.1679688 L 10.554688 8.8320312 L 12.546875 7.5039062 C 13.041875 7.1739062 13.616938 7 14.210938 7 L 18.595703 7 C 19.921703 7 21 8.0782969 21 9.4042969 C 21 10.120297 20.684766 10.794906 20.134766 11.253906 L 19.240234 12 L 8 12 L 8 14 L 16.839844 14 L 13.238281 17 L 8 17 L 8 19 L 10.839844 19 L 10.585938 19.210938 C 9.5789375 20.050937 9 21.284703 9 22.595703 C 9 25.024703 10.975297 27 13.404297 27 L 17.789062 27 C 18.779063 27 19.7385 26.709156 20.5625 26.160156 L 22.554688 24.832031 L 21.445312 23.167969 L 19.453125 24.496094 C 18.958125 24.826094 18.383063 25 17.789062 25 L 13.404297 25 C 12.078297 25 11 23.921703 11 22.595703 C 11 21.879703 11.315234 21.205094 11.865234 20.746094 L 13.960938 19 L 24 19 L 24 17 L 16.361328 17 L 19.960938 14 L 24 14 L 24 12 L 22.150391 12 C 22.696104 11.25367 23 10.350098 23 9.4042969 C 23 6.9752969 21.024703 5 18.595703 5 L 14.210938 5 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
