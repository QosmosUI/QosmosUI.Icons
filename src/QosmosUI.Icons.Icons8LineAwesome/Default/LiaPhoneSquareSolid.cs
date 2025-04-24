// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaPhoneSquareSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 5 5 L 5 27 L 27 27 L 27 5 L 5 5 z M 7 7 L 25 7 L 25 25 L 7 25 L 7 7 z M 11.871094 9.0019531 C 11.380969 9.0019531 10.889625 9.1875469 10.515625 9.5605469 L 9.5605469 10.515625 C 9.0345469 11.043625 8.8604219 11.805953 9.1074219 12.501953 L 9.1503906 12.632812 C 9.3153906 13.135813 9.7018906 14.312688 10.962891 16.179688 C 11.574891 17.087688 12.283547 17.937313 13.060547 18.695312 L 13.294922 18.929688 C 14.060922 19.713687 14.908406 20.421156 15.816406 21.035156 C 17.685406 22.296156 18.864188 22.681656 19.367188 22.847656 L 19.498047 22.892578 C 19.707047 22.965578 19.923719 23.001953 20.136719 23.001953 C 20.632719 23.001953 21.115375 22.8065 21.484375 22.4375 L 22.439453 21.484375 C 22.801453 21.121375 23 20.641859 23 20.130859 C 23 19.618859 22.801453 19.136391 22.439453 18.775391 L 21.289062 17.626953 C 20.566063 16.903953 19.304078 16.903953 18.580078 17.626953 L 16.873047 19.333984 C 16.102047 18.806984 15.37875 18.199437 14.71875 17.523438 L 14.46875 17.273438 C 13.79875 16.619438 13.193969 15.896953 12.667969 15.126953 L 14.375 13.419922 C 14.737 13.058922 14.935547 12.575453 14.935547 12.064453 C 14.935547 11.553453 14.737 11.073937 14.375 10.710938 L 13.222656 9.5605469 C 12.850156 9.1885469 12.361219 9.0019531 11.871094 9.0019531 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
