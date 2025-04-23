// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Typicons;

public class TiNotesOutline : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
    public string ViewBox { get; set; } = "0 0 24 24";

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
		builder.AddAttribute(14, "d", "M18.324 4.367c-.368-.324-.84-.5-1.324-.5l-.248.016-9 1.25c-1.001.125-1.752.975-1.752 1.984v6.111c-1.746.551-3 2.034-3 3.772 0 2.205 2.019 4 4.5 4 1.695 0 3.169-.842 3.937-2.078.803.667 1.879 1.078 3.063 1.078 2.481 0 4.5-1.795 4.5-4v-10.133c0-.574-.246-1.119-.676-1.5zm-7.324 11.633v-4.256l3-.45v1.737c-1.693.208-3 1.46-3 2.969zm6 0c0 1.104-1.119 2-2.5 2s-2.5-.896-2.5-2 1.119-2 2.5-2c.172 0 .338.014.5.041v-3.908l-5 .75v6.117c0 1.104-1.119 2-2.5 2s-2.5-.896-2.5-2 1.119-2 2.5-2c.172 0 .338.014.5.041v-7.924l9-1.25v10.133z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
