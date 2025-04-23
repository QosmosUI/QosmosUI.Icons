// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcVlc : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "48px";

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
    public string ViewBox { get; set; } = "0 0 48 48";

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
		builder.AddAttribute(14, "fill", "#F57C00");
		builder.AddAttribute(15, "d", "M36.258,28.837c0,0-0.11-0.837-1.257-0.837c-0.216,0-2.392,0-3.719,0c0.798,2.671,1.497,5.135,1.497,5.279	c0,2.387-3.401,3.393-8.917,3.393c-5.515,0-8.651-0.94-8.651-3.326c0-0.167,0.998-2.692,1.791-5.346c-1.591,0-3.863,0-4.063,0	c-0.806,0-0.937,0.749-0.937,0.749L8.159,40.986L8.815,42h30.652l0.376-1.014L36.258,28.837z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "fill", "#E0E0E0");
		builder.AddAttribute(18, "d", "M24.001,6c-1.029,0-1.864,0.179-1.864,0.398c-0.492,1.483-8.122,26.143-8.122,26.774	c0,2.388,4.471,3.827,9.985,3.827s9.986-1.439,9.986-3.827c0-0.549-7.614-25.268-8.122-26.774C25.865,6.179,25.031,6,24.001,6	L24.001,6z");
		builder.CloseElement();
		builder.OpenElement(19, "g");
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "fill", "#FF9800");
		builder.AddAttribute(22, "d", "M33.196,30.447C32.032,32.232,28.341,34,24.046,34c-4.34,0-8.156-1.696-9.281-3.51		c-0.499,1.483-0.892,2.647-0.892,3.28c0,2.386,4.533,4.229,10.128,4.229c5.595,0,10.131-1.844,10.131-4.229		C34.132,33.222,33.713,31.955,33.196,30.447z");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "fill", "#FF9800");
		builder.AddAttribute(25, "d", "M31.387,24.314l-2.074-6.794c0,0-1.857,1.479-5.311,1.479c-3.453,0-5.316-1.479-5.316-1.479l-2.081,6.806		c0,0,2.068,2.674,7.397,2.674C29.375,27,31.387,24.314,31.387,24.314z");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "fill", "#FF9800");
		builder.AddAttribute(28, "d", "M27.241,10.809l-1.376-4.41c0,0-0.083-0.398-1.864-0.398c-1.844,0-1.864,0.398-1.864,0.398l-1.376,4.407		c0,0,0.885,1.194,3.239,1.194C26.355,12,27.241,10.809,27.241,10.809z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
