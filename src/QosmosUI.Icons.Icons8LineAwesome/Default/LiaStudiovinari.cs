// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaStudiovinari : ComponentBase
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
		builder.AddAttribute(14, "d", "M 3.5898438 3 L 8.734375 8.484375 L 3 7.5644531 L 11.328125 13.806641 L 7.1699219 14.339844 L 16 17 L 15 18 L 21.570312 16.787109 L 20.818359 20.261719 L 17.935547 22.876953 L 13.451172 25.171875 L 12.400391 24.515625 L 12.050781 24.794922 L 11 28.533203 L 11.328125 28.462891 L 12.486328 27.039062 L 15.326172 25.171875 L 20.023438 23.845703 L 16.636719 25.806641 C 16.636719 25.806641 15.711469 25.769531 15.605469 25.769531 C 15.499469 25.769531 14.619141 29 14.619141 29 L 15.105469 28.796875 L 15.496094 28.1875 L 16.396484 26.943359 L 20.412109 25.023438 L 23.261719 21.595703 L 25.283203 17.615234 L 26.558594 15.376953 L 26.558594 13.953125 L 26.345703 12.53125 L 25.8125 11.318359 L 26.335938 10.292969 L 27 9.9160156 L 26.568359 9.3046875 L 26.923828 8.9902344 L 26.339844 8.7773438 L 24.855469 7.5234375 L 22.935547 8.0507812 L 22.722656 9.9707031 L 23.789062 10.804688 L 23.179688 11.255859 L 17.695312 6.3613281 L 19.875 9.1953125 L 10 3 L 12.304688 7.28125 L 14.822266 8.1992188 L 13.873047 6.25 L 21.150391 11.277344 L 14.832031 7.4980469 L 16.433594 9.4296875 L 3.5898438 3 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
