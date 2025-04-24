// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiMatillion : ComponentBase
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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M12 0c-.552 0-1.104.142-1.598.428L2.777 4.831A3.195 3.195 0 0 0 1.18 7.597v8.806c0 1.141.609 2.195 1.597 2.766l7.625 4.403a3.194 3.194 0 0 0 3.195 0l7.626-4.403a3.195 3.195 0 0 0 1.597-2.766V7.597a3.194 3.194 0 0 0-1.597-2.766L13.597.428A3.183 3.183 0 0 0 12 0Zm.033 6.215a1.383 1.383 0 0 1 1.012 2.286l-7.277 8.403a1.382 1.382 0 0 1-2.09-1.81l7.278-8.402a1.374 1.374 0 0 1 1.077-.477Zm2.689 3.105.025.001.059.002.082.005.055.007a1.373 1.373 0 0 1 .135.026l.073.019.035.012.091.034.038.017c.03.013.058.027.087.043l.033.018c.026.015.052.031.077.048l.045.031.071.055c.005.005.012.008.018.013l.019.019c.023.02.044.041.065.062l.037.039.031.033 4.533 5.296a1.38 1.38 0 0 1-1.049 2.281h-.001a1.38 1.38 0 0 1-1.05-.484l-3.484-4.07-3.482 4.07a1.38 1.38 0 0 1-1.051.484h-.001A1.38 1.38 0 0 1 9.164 15.1l4.533-5.296.03-.033.037-.039.062-.059.023-.022.022-.017.066-.05c.016-.011.031-.023.047-.033a1.23 1.23 0 0 1 .067-.042l.049-.027.072-.036a1.12 1.12 0 0 1 .177-.066.932.932 0 0 1 .141-.035l.06-.01.058-.007.081-.005.033-.003Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
