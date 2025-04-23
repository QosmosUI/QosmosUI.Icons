// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.AntDesignIcons.Outline;

public class AiOutlineHolder : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 1024 1024";

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
		builder.AddAttribute(14, "d", "M300,276.497424 C317.32646,286.500861 338.67354,286.500861 356,276.497424 C373.326461,266.493987 384,248.006874 384,228 C384,207.993128 373.326461,189.506014 356,179.502578 C338.67354,169.499141 317.32646,169.499141 300,179.502578 C282.673539,189.506014 272,207.993128 272,228 C272,248.006874 282.673539,266.493987 300,276.497424 Z M300,560.497426 C317.32646,570.500863 338.67354,570.500863 356,560.497426 C373.326461,550.493989 384,532.006876 384,512.000002 C384,491.993129 373.326461,473.506016 356,463.502579 C338.67354,453.499142 317.32646,453.499142 300,463.502579 C282.673539,473.506016 272,491.993129 272,512.000002 C272,532.006876 282.673539,550.493989 300,560.497426 Z M640,228 C640,248.006874 650.673539,266.493987 668,276.497424 C685.32646,286.500861 706.67354,286.500861 724,276.497424 C741.326461,266.493987 752,248.006874 752,228 C752,207.993128 741.326461,189.506014 724,179.502578 C706.67354,169.499141 685.32646,169.499141 668,179.502578 C650.673539,189.506014 640,207.993128 640,228 L640,228 Z M640,512.000002 C640,532.006876 650.673539,550.493989 668,560.497426 C685.32646,570.500863 706.67354,570.500863 724,560.497426 C741.326461,550.493989 752,532.006876 752,512.000002 C752,491.993129 741.326461,473.506016 724,463.502579 C706.67354,453.499142 685.32646,453.499142 668,463.502579 C650.673539,473.506016 640,491.993129 640,512.000002 L640,512.000002 Z M300,844.497427 C317.32646,854.500864 338.67354,854.500864 356,844.497427 C373.326461,834.493991 384,816.006877 384,796.000003 C384,775.993131 373.326461,757.506018 356,747.502581 C338.67354,737.499144 317.32646,737.499144 300,747.502581 C282.673539,757.506018 272,775.993131 272,796.000003 C272,816.006877 282.673539,834.493991 300,844.497427 Z M640,796.000003 C640,816.006877 650.673539,834.493991 668,844.497427 C685.32646,854.500864 706.67354,854.500864 724,844.497427 C741.326461,834.493991 752,816.006877 752,796.000003 C752,775.993131 741.326461,757.506018 724,747.502581 C706.67354,737.499144 685.32646,737.499144 668,747.502581 C650.673539,757.506018 640,775.993131 640,796.000003 L640,796.000003 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
