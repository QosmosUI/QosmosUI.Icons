// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaSkiingNordicSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 14.5 4 C 12.57 4 11 5.57 11 7.5 C 11 9.43 12.57 11 14.5 11 C 16.43 11 18 9.43 18 7.5 C 18 5.57 16.43 4 14.5 4 z M 14.5 6 C 15.327 6 16 6.673 16 7.5 C 16 8.327 15.327 9 14.5 9 C 13.673 9 13 8.327 13 7.5 C 13 6.673 13.673 6 14.5 6 z M 13.685547 11.992188 C 13.281391 11.952719 12.869469 12.037281 12.511719 12.238281 C 12.034719 12.506281 11.683594 12.965797 11.558594 13.466797 L 10.060547 18.740234 C 9.8645469 19.523234 10.155453 20.341938 10.814453 20.835938 L 14.019531 23.177734 L 14.78125 27 L 9.9550781 27 L 10.984375 25.587891 C 11.055375 25.456891 11.116062 25.3215 11.164062 25.1875 L 11.992188 22.921875 L 10.306641 21.703125 L 9.2832031 24.507812 C 9.2662031 24.552813 9.2466094 24.596719 9.2246094 24.636719 L 7.5019531 27 L 3 27 L 3 29 L 24.486328 29 C 26.512328 29 28.302406 27.709062 28.941406 25.789062 L 29 25.617188 L 27.103516 24.984375 L 27.046875 25.15625 C 26.677875 26.25825 25.649328 27 24.486328 27 L 21 27 L 21 16 L 16.755859 16 L 15.970703 13.664062 C 15.801703 12.992063 15.285047 12.447234 14.623047 12.240234 L 14.085938 12.074219 C 13.955687 12.033219 13.820266 12.005344 13.685547 11.992188 z M 13.490234 13.984375 L 14.056641 14.238281 L 14.841797 16.46875 C 15.063797 17.36075 15.86125 17.982422 16.78125 17.982422 L 19 17.982422 L 19 27 L 16.820312 27 L 15.986328 22.818359 C 15.902328 22.307359 15.627219 21.856156 15.199219 21.535156 L 11.992188 19.255859 L 13.490234 13.984375 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
